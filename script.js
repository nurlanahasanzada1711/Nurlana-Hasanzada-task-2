let ilkin_saat = 1;
let faiz1 = 20;
let faiz2 = 50;
let faiz3 = 75;

let saat = 7;
let umumi_mebleg;

if (saat <= 3) {
    umumi_mebleg = saat * ilkin_saat;
}
else if (saat <= 5 && saat >= 3) {
    umumi_mebleg = 3 * ilkin_saat + (ilkin_saat - (faiz1 / 100)) * (saat - 3);
}
else if (saat <= 8) {
    umumi_mebleg = 3 * ilkin_saat + (ilkin_saat - (faiz1 / 100)) * 2 + (ilkin_saat - (faiz2 / 100)) * (saat - 5);
}
else {
    umumi_mebleg = 3 * ilkin_saat + (ilkin_saat - (faiz1 / 100)) * 2 + (ilkin_saat - (faiz2 / 100)) * 3 + (ilkin_saat - (faiz3 / 100)) * (saat - 8);
}
console.log(umumi_mebleg);