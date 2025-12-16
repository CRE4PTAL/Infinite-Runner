# RoboRunner - Infinite Runner 2D 🤖

Dynamiczna gra zręcznościowa typu "Endless Runner" stworzona w silniku Unity. Gracz steruje robotem, którego celem jest przetrwanie jak najdłużej w nieskończonym, proceduralnie generowanym świecie pełnym przeszkód.

## 🛠 Technologie
* **Silnik:** Unity (2D)
* **Język:** C#
* **Grafika:** Pixel Art

## 🌟 Główne funkcjonalności
* **Proceduralne generowanie poziomu:** Przeszkody pojawiają się w losowych odstępach i konfiguracjach, zapewniając unikalność każdej rozgrywki.
* **System Power-Upów:**
  * 🔩 **Śrubka:** Bonus punktowy (waluta w grze).
  * 🔋 **Bateria:** Czasowa nieśmiertelność (Invincibility Mode), pozwalająca na ignorowanie kolizji z przeszkodami.
* **Fizyka i sterowanie:** Responsywny system skoku oparty na `Rigidbody2D`.
* **UI/UX:** Licznik punktów w czasie rzeczywistym oraz ekran "Game Over" z możliwością natychmiastowego restartu.

## 💡 Wyzwania i rozwiązania
Kluczowym elementem była optymalizacja i płynność generowania świata.
* **Spawning System:** Napisałem skrypt menedżera (Spawner), który instancjonuje przeszkody poza prawą krawędzią kamery i niszczy je po wyjściu poza lewą krawędź ekranu, aby nie obciążać pamięci.
* **Logika Nieśmiertelności:** Power-up "Bateria" uruchamia `Coroutine`, która czasowo wyłącza detekcję kolizji z warstwą "Przeszkody" i zmienia wizualny stan gracza, a po upływie czasu przywraca domyślne ustawienia.

## 🎮 Sterowanie
* **Lewy przycisk myszy:** Skok (Jump)

## 💻 Uruchomienie projektu (Unity)

1. Wejdź w zakładkę Releases (po prawej stronie ekranu)
2. Kliknij "InfiniteRunner"
3. Pobierz ZIP'a i go rozpakuj
4. Uruchom InfinityRunner.exe
