string? slot="all";
string? guntype="all";

Dictionary<string, (string,string)> guns = new();
guns["AK-12"] = ("primary", "assault rifle");
guns["AK-74"] = ("primary", "assault rifle");
guns["AK-74M"] = ("primary", "assault rifle");
guns["AK-74N"] = ("primary", "assault rifle");
guns["AK-101"] = ("primary", "assault rifle");
guns["AK-102"] = ("primary", "assault rifle");
guns["AK-103"] = ("primary", "assault rifle");
guns["AK-104"] = ("primary", "assault rifle");
guns["AK-105"] = ("primary", "assault rifle");
guns["AKM"] = ("primary", "assault rifle");
guns["AKMN"] = ("primary", "assault rifle");
guns["AKMS"] = ("primary", "assault rifle");
guns["AKMSN"] = ("primary", "assault rifle");
guns["AKS-74"] = ("primary", "assault rifle");
guns["AKS-74N"] = ("primary", "assault rifle");
guns["AKS-74U"] = ("primary", "assault rifle");
guns["AKS-74UB"] = ("primary", "assault rifle");
guns["AKS-74UN"] = ("primary", "assault rifle");
guns["AS VAL"] = ("primary", "assault rifle");
guns["ASh-12"] = ("primary", "assault rifle");
guns["AUG A1"] = ("primary", "assault rifle");
guns["AUG A3"] = ("primary", "assault rifle");
guns["DT MDR 5.56x45"] = ("primary", "assault rifle");
guns["DT MDR 7.62x51"] = ("primary", "assault rifle");
guns["G36"] = ("primary", "assault rifle");
guns["HK 416A5"] = ("primary", "assault rifle");
guns["M4A1"] = ("primary", "assault rifle");
guns["MCX"] = ("primary", "assault rifle");
guns["MCX-SPEAR"] = ("primary", "assault rifle");
guns["MK47"] = ("primary", "assault rifle");
guns["RD-704"] = ("primary", "assault rifle");
guns["SA58"] = ("primary", "assault rifle");
guns["SCAR-H"] = ("primary", "assault rifle");
guns["SCAR-L"] = ("primary", "assault rifle");
guns["Velociraptor"] = ("primary", "assault rifle");

// Assault assault carbines
guns["9A-91"] = ("primary", "assault carbine");
guns["ADAR 2-15"] = ("primary", "assault carbine");
guns["AVT-40"] = ("primary", "assault carbine");
guns["OP-SKS"] = ("primary", "assault carbine");
guns["RFB"] = ("primary", "assault carbine");
guns["SAG AK-545"] = ("primary", "assault carbine");
guns["SAG AK-545 Short"] = ("primary", "assault carbine");
guns["SKS"] = ("primary", "assault carbine");
guns["SR-3M"] = ("primary", "assault carbine");
guns["SVT-40"] = ("primary", "assault carbine");
guns["TX-15 DML"] = ("primary", "assault carbine");
guns["VPO-101"] = ("primary", "assault carbine");
guns["VPO-136"] = ("primary", "assault carbine");
guns["VPO-209"] = ("primary", "assault carbine");
guns["VSK-94"] = ("primary", "assault carbine");

// sniper Rifles
guns["AXMC"] = ("primary", "sniper");
guns["DVL-10"] = ("primary", "sniper");
guns["M700"] = ("primary", "sniper");
guns["Mosin Infantry"] = ("primary", "sniper");
guns["Mosin Sniper"] = ("primary", "sniper");
guns["SV-98"] = ("primary", "sniper");
guns["T-5000M"] = ("primary", "sniper");
guns["TRG M10"] = ("primary", "sniper");
guns["VPO-215"] = ("primary", "sniper");

// Designated Marksman Rifles
guns["G28"] = ("primary", "dmr");
guns["M1A"] = ("primary", "dmr");
guns["Mk-18"] = ("primary", "dmr");
guns["RSASS"] = ("primary", "dmr");
guns["SR-25"] = ("primary", "dmr");
guns["SVDS"] = ("primary", "dmr");
guns["VSS Vintorez"] = ("primary", "dmr");

// Submachine Guns
guns["MP5"] = ("primary", "smg");
guns["MP5K"] = ("primary", "smg");
guns["MP7A1"] = ("primary", "smg");
guns["MP7A2"] = ("primary", "smg");
guns["MP9"] = ("primary", "smg");
guns["MPX"] = ("primary", "smg");
guns["P90"] = ("primary", "smg");
guns["PP-9 Klin"] = ("primary", "smg");
guns["PP-19-01"] = ("primary", "smg");
guns["PP-91 Kedr"] = ("primary", "smg");
guns["PP-91-01 Kedr-B"] = ("primary", "smg");
guns["PPSh-41"] = ("primary", "smg");
guns["Saiga-9"] = ("primary", "smg");
guns["SR-2M"] = ("primary", "smg");
guns["STM-9"] = ("primary", "smg");
guns["UMP-45"] = ("primary", "smg");
guns["UZI"] = ("primary", "smg");
guns["UZI PRO Pistol"] = ("primary", "smg");
guns["UZI PRO SMG"] = ("primary", "smg");
guns["Vector .45"] = ("primary", "smg");
guns["Vector 9x19"] = ("primary", "smg");

// Shotguns
guns["MP-43 sawed-off"] = ("secondary", "shotgun");
guns["AA-12 Gen 1"] = ("primary", "shotgun");
guns["AA-12 Gen 2"] = ("primary", "shotgun");
guns["KS-23M"] = ("primary", "shotgun");
guns["M3 Super 90"] = ("primary", "shotgun");
guns["M590A1"] = ("primary", "shotgun");
guns["M870"] = ("primary", "shotgun");
guns["MP-18"] = ("primary", "shotgun");
guns["MP-43-1C"] = ("primary", "shotgun");
guns["MP-133"] = ("primary", "shotgun");
guns["MP-153"] = ("primary", "shotgun");
guns["MP-155"] = ("primary", "shotgun");
guns["MTs-255-12"] = ("primary", "shotgun");
guns["Saiga-12K"] = ("primary", "shotgun");
guns["Saiga-12K FA"] = ("primary", "shotgun");
guns["TOZ-106"] = ("primary", "shotgun");

// Machine Guns / Light Machine Guns
guns["RPD"] = ("primary", "mg");
guns["RPDN"] = ("primary", "mg");
guns["RPK-16"] = ("primary", "mg");
guns["PKM"] = ("primary", "mg");
guns["PKP"] = ("primary", "mg");
guns["M60E4"] = ("primary", "mg");
guns["M60E6"] = ("primary", "mg");

// Pistols / Revolvers
guns["APB"] = ("secondary", "pistol");
guns["APS"] = ("secondary", "pistol");
guns["Blicky"] = ("secondary", "pistol");
guns["Desert Eagle L5 .357"] = ("secondary", "pistol");
guns["Desert Eagle L5 .50 AE"] = ("secondary", "pistol");
guns["Desert Eagle L6"] = ("secondary", "pistol");
guns["Desert Eagle L6 (WTS)"] = ("secondary", "pistol");
guns["Desert Eagle Mk XIX"] = ("secondary", "pistol");
guns["FN 5-7"] = ("secondary", "pistol");
guns["Glock 17"] = ("secondary", "pistol");
guns["Glock 18C"] = ("secondary", "pistol");
guns["Glock 19X"] = ("secondary", "pistol");
guns["M9A3"] = ("secondary", "pistol");
guns["M45A1"] = ("secondary", "pistol");
guns["M1911A1"] = ("secondary", "pistol");
guns["MP-443 Grach"] = ("secondary", "pistol");
guns["P226R"] = ("secondary", "pistol");
guns["PB pistol"] = ("secondary", "pistol");
guns["PL-15"] = ("secondary", "pistol");
guns["PM (t) pistol"] = ("secondary", "pistol");
guns["PM pistol"] = ("secondary", "pistol");
guns["SR-1MP Gyurza"] = ("secondary", "pistol");
guns["TT pistol"] = ("secondary", "pistol");
guns["TT pistol (gold)"] = ("secondary", "pistol");
guns["USP .45"] = ("secondary", "pistol");
guns["CR 50DS"] = ("secondary", "pistol");
guns["CR 200DS"] = ("secondary", "pistol");
guns["RSH-12"] = ("secondary", "pistol");

// Other (Launchers, Specials)
guns["M32A1"] = ("primary", "other");

string[] gunsInTarkov = new string[] {
    // Assault Rifles
    "AK-12", "AK-74", "AK-74M", "AK-74N", "AK-101", "AK-102", "AK-103", "AK-104", "AK-105", "AKM", "AKMN", "AKMS", "AKMSN", "AKS-74", "AKS-74N", "AKS-74U", "AKS-74UB", "AKS-74UN", "AS VAL", "ASh-12", "AUG A1",
    "AUG A3", "DT MDR 5.56x45", "DT MDR 7.62x51", "G36", "HK 416A5", "M4A1", "MCX", "MCX-SPEAR", "MK47", "RD-704", "SA58", "SCAR-H", "SCAR-L", "Velociraptor",

    // Assault assault carbines
    "9A-91", "ADAR 2-15", "AVT-40", "OP-SKS", "RFB", "SAG AK-545", "SAG AK-545 Short", "SKS", "SR-3M", "SVT-40", "TX-15 DML", "VPO-101", "VPO-136", "VPO-209", "VSK-94",

    // sniper Rifles
    "AXMC", "DVL-10", "M700", "Mosin Infantry", "Mosin Sniper", "SV-98", "T-5000M", "TRG M10", "VPO-215",

    // Designated Marksman Rifles
    "G28", "M1A", "Mk-18", "RSASS", "SR-25", "SVDS", "VSS Vintorez",

    // Submachine Guns
    "MP5", "MP5K", "MP7A1", "MP7A2", "MP9", "MPX", "P90", "PP-9 Klin", "PP-19-01", "PP-91 Kedr", "PP-91-01 Kedr-B", "PPSh-41", "Saiga-9", "SR-2M", "STM-9", "UMP-45", "UZI", "UZI PRO Pistol", "UZI PRO SMG",
    "Vector .45", "Vector 9x19",

    // Shotguns
    "MP-43 sawed-off", "AA-12 Gen 1", "AA-12 Gen 2", "KS-23M", "M3 Super 90", "M590A1", "M870", "MP-18", "MP-43-1C", "MP-133", "MP-153", "MP-155", "MTs-255-12", "Saiga-12K", "Saiga-12K FA", "TOZ-106",

    // Machine Guns / Light Machine Guns
    "RPD", "RPDN", "RPK-16", "PKM", "PKP", "M60E4", "M60E6",

    // Pistols / Revolvers
    "APB", "APS", "Blicky", "Desert Eagle L5 .357", "Desert Eagle L5 .50 AE", "Desert Eagle L6", "Desert Eagle L6 (WTS)", "Desert Eagle Mk XIX", "FN 5-7", "Glock 17", "Glock 18C", "Glock 19X",
    "M9A3", "M45A1", "M1911A1", "MP-443 Grach", "P226R", "PB pistol", "PL-15", "PM (t) pistol", "PM pistol", "SR-1MP Gyurza", "TT pistol", "TT pistol (gold)", "USP .45", "CR 50DS", "CR 200DS", "RSH-12",

    // Other (Launchers, Specials)
    "M32A1", "FN40", "SP-81"
};

while (true)
{
    Console.WriteLine("Type G to generate gun, p to print all guns and attributes or any other button to change filters!");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Current filter: Slot: " + slot.ToUpper()+" ; Guntype: " + guntype.ToUpper());
    Console.ResetColor();
    Console.WriteLine();
    ConsoleKey k = Console.ReadKey(true).Key;
    if(k == ConsoleKey.G)
    {
        PickWeapon(slot, guntype);
    }
    else if(k == ConsoleKey.P)
    {
        for(int i = 0; i<guns.Count;i++)
        {
            Console.WriteLine($"#{i+1}: Gun: {gunsInTarkov[i]} \n\t Slot: {guns[gunsInTarkov[i]].Item1}\n\t Type: {guns[gunsInTarkov[i]].Item2}");
        }
    }
    else
    {
        Console.WriteLine();
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Enter slottype (All, Primary, Secondary): ");
            slot = Console.ReadLine();
            Console.Write("Enter guntype (Assault Rifle, Smg, Sniper...): ");
            guntype = Console.ReadLine();
            Console.ResetColor();
            Console.WriteLine();

            if (new string[] { "primary", "secondary", "all" }.Contains(slot.ToLower()) && new string[] { "assault rifle", "assault carbine", "sniper","dmr","smg","shotgun","mg","pistol","other","all" }.Contains(guntype.ToLower()))
                break;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid Slot or Guntype!\n");
            Console.ResetColor();
        }
    }
}

void PickWeapon(string? slot, string? guntype)
{
    Console.ForegroundColor= ConsoleColor.Red;
    if(slot == "secondary"&&new string[] {"assault rifle","sniper","assault carbine","dmr","smg","other" }.Contains(guntype))
    {
        Console.WriteLine("This filter combination doesnt exist!\n");
        Console.ResetColor();
        return;
    }
    if(slot =="primary"&&guntype == "pistol")
    {
        Console.WriteLine("This filter combination doesnt exist!\n");
        Console.ResetColor();
        return;
    }
    Console.ForegroundColor = ConsoleColor.Green;
    if (slot == "all" && guntype == "all")
    {
        int random = Random.Shared.Next(0, guns.Count);
        Console.WriteLine("The selected gun: " + gunsInTarkov[random]);
    }
    else if(slot != "all" && guntype=="all")
    {
        List<string> list = new List<string>();
        for(int i = 0; i < guns.Count; i++)
        {
            if ((slot, guns[gunsInTarkov[i]].Item2)==(guns[gunsInTarkov[i]].Item1, guns[gunsInTarkov[i]].Item2))
            {
                list.Add(gunsInTarkov[i]);
            }
        }

        int random = Random.Shared.Next(0, list.Count);
        Console.WriteLine("The selected gun: " + list[random]);
    }
    else if(slot == "all" && guntype!= "all")
    {
        List<string> list = new List<string>();
        for (int i = 0; i < guns.Count; i++)
        {
            if ((guns[gunsInTarkov[i]].Item1, guntype) == (guns[gunsInTarkov[i]].Item1, guns[gunsInTarkov[i]].Item2))
            {
                list.Add(gunsInTarkov[i]);
            }
        }

        int random = Random.Shared.Next(0, list.Count);
        Console.WriteLine("The selected gun: " + list[random]);
    }
    else
    {
        List<string> list = new List<string>();
        for (int i = 0; i < guns.Count; i++)
        {
            if ((slot, guntype) == (guns[gunsInTarkov[i]].Item1, guns[gunsInTarkov[i]].Item2))
            {
                list.Add(gunsInTarkov[i]);
            }
        }

        int random = Random.Shared.Next(0, list.Count);
        Console.WriteLine("The selected gun: " + list[random]);
    }
    Console.ResetColor();
    Console.WriteLine("\n\n");
}