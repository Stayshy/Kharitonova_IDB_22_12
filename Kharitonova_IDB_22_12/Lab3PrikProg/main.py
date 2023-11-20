
import re
from html.parser import HTMLParser


class MyHTMLParser(HTMLParser):
    def __init__(self):
        super().__init__()
        self.found_emails = []

    def handle_data(self, data):
        # Используем регулярное выражение для поиска e-mail адресов
        emails = re.findall(r'[\w\.-]+@[\w\.-]+', data)
        self.found_emails.extend(emails)

# Считываем HTML-файл
file_path = '1.html'  # Замените на путь к вашему HTML-файлу
with open(file_path, 'r', encoding='utf-8') as file:
    html_doc = file.read()

# Инициализируем и используем наш парсер HTML
parser = MyHTMLParser()
parser.feed(html_doc)

# Выводим найденные e-mail адреса
print("Найденные e-mail адреса:")
for email in parser.found_emails:
    print(email)