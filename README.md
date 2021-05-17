# WinformsAssesment

Sie finden ein .net 5.0 Projekt mit einem Projekt, dass einen IO Zugriff simuliert. Bitte bearbeiten Sie folgende Aufgaben:

1. Erstellen Sie eine WinForm Oberfläche über die ein Ordner ausgewählt und anschließend mit einem Button der IOWorker angestoßen wird. Zeigen Sie Fehler, die der IOWorker ggf. wirft in der Oberfläche an.
2. Beim Ausführen Blockiert der IOWorker die Oberfläche. Passen Sie die DoWork() Methode so an, dass diese die WinForms Oberfläche nicht mehr blockiert. Während der IOWorker arbeitet darf kein neuer IOWorker angestoßen werden.
3. Bauen Sie einen weiteren Button in die Oberfläche über die der IOWorker abgebrochen werden kann. Dieser Button soll nur aktiv sein, wenn auch wirklich gearbeitet wird.
