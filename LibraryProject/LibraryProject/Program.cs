using LibraryProject;

Library kitap1 = new Library();

Console.WriteLine($"Kitabın İsmi : {kitap1.Ad}\n\nYazar : {kitap1.YazarAd}\n\nSayfa Sayısı : {kitap1.SayfaSayisi}\n\nYayın Evi : {kitap1.YayinEvi}\n\nKayıt Tarihi : {kitap1.KayitTarihi}");


Console.WriteLine("-----------------------------------------------------------");


Library kitap2 = new Library("Yüzüklerin Efendisi", "J.R.", "Tolkien", 1900, "Keşan Kitap Evi");

Console.WriteLine($"Kitabın İsmi : {kitap2.Ad}\n\nYazar : {kitap2.YazarAd} {kitap2.YazarSoyad}\n\nSayfa Sayısı : {kitap2.SayfaSayisi}\n\nYayın Evi : {kitap2.YayinEvi}\n\nKayıt Tarihi : {kitap2.KayitTarihi}");


