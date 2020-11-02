#include <Windows.h>
#include <vector>
#include <TlHelp32.h>


uintptr_t FindDMAADDY(HANDLE hProcess, uintptr_t ptr, std::vector<unsigned int> imposteroffsets)
{
	uintptr_t addr = ptr;
	for (unsigned int i = 0; i < imposteroffsets.size(); i++)
	{
		ReadProcessMemory(hProcess, (LPCVOID)addr, &addr, sizeof(addr), NULL);
		addr += imposteroffsets[i];
	}
	return addr;
}

uintptr_t GetModuleBaseAddress(DWORD procId, const wchar_t* modName)
{
	uintptr_t modBaseAddr = 0;
	HANDLE hSnap = CreateToolhelp32Snapshot(TH32CS_SNAPMODULE | TH32CS_SNAPMODULE32, procId);
	if (hSnap != INVALID_HANDLE_VALUE)
	{
		MODULEENTRY32 modEntry;
		modEntry.dwSize = sizeof(modEntry);
		if (Module32First(hSnap, &modEntry))
		{
			do
			{
				if (!_wcsicmp(modEntry.szModule, modName))
				{
					modBaseAddr = (uintptr_t)modEntry.modBaseAddr;
					break;
				}
			} while (Module32First(hSnap, &modEntry));
		}

	}
	CloseHandle(hSnap);
	return modBaseAddr;
}


int main()
{
	HWND hwnd = FindWindowA(NULL, "Among us");

	if (hwnd == NULL)
	{
		MessageBoxA(NULL, "Couldn't find among us. Check if is running", "Error", NULL);
	}
	else
	{
		DWORD procID;

		GetWindowThreadProcessId(hwnd, &procID);

		HANDLE hProcess = OpenProcess(PROCESS_ALL_ACCESS, FALSE, procID);

		uintptr_t modulebase = GetModuleBaseAddress(procID, L"GameAssembly.dll");

		uintptr_t dynamicptrbaseaddr = modulebase + 0x0146F918;

		std::vector<unsigned int> imposteroffsets = { 0x5C, 0x80, 0x34, 0x28 };

		uintptr_t imposteraddr = FindDMAADDY(hProcess, dynamicptrbaseaddr, imposteroffsets);

		bool on = 1;

		WriteProcessMemory(hProcess, (LPVOID)imposteraddr, &on, sizeof(on), NULL);
	}

	return 0;
}