using BuilderDemo;

WeaponBuilder weaponBuilder = new WeaponBuilder();
Weapon ak74u = weaponBuilder.Durability(75).Strength(4).Weight(5).Name("AK-74U").Build();
Weapon zweihander = weaponBuilder.Durability(100).Strength(15).Weight(7).Name("Zweihander").Build();

ArmorBuilder armorBuilder = new ArmorBuilder();
Armor knightsHelm = armorBuilder.Defence(40).Durability(150).Name("Knight's Helm").Build();
Armor knightsChestpiece = armorBuilder.Defence(50).Durability(200).Name("Knight's Chestpiece").Build();
Armor knightsGauntlets = armorBuilder.Defence(30).Durability(75).Name("Knight's Gauntlets").Build();
Armor knightsGreaves = armorBuilder.Defence(25).Durability(125).Name("Knight's Greaves").Build();
Armor knightsBoots = armorBuilder.Defence(25).Durability(75).Name("Knight's Boots").Build();

Armor ghzelle3Vest = armorBuilder.Defence(35).Durability(120).Name("GHZELLE-3 Bulletproof Vest").Build();
Armor ratnikHelm = armorBuilder.Defence(35).Durability(50).Name("Ratnik Bulletproof Helm").Build();
Armor razorVisor = armorBuilder.Defence(35).Durability(25).Name("RAZOR Bulletproof visor").Build();


SoldierBuilder soldierBuild1 = new SoldierBuilder();
soldierBuild1
    .Name("Harold")
    .Health(15)
    .Age(56)
    .AddArmor(knightsHelm)
    .AddArmor(knightsChestpiece)
    .AddArmor(knightsGauntlets)
    .AddArmor(knightsGreaves)
    .AddArmor(knightsBoots)
    .Weapons(ak74u)
    .Build();