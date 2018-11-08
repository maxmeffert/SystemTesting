System Testing
==============

TL;DR
=====
- Einführung:
  - Unit Tests
  - Integration & Integrated Tests
  - System Tests
  - Behavior Driven Development
- Beispiel: AspNetCore-Rest-Api
  - Probleme von Unit Tests (NUnit + Moq) mit Regressionen bei stark entkoppelten Software-Design
  - System Tests mit NUnit und Behavior Driven Development als Gegenstrategie

Abstract
========
Software testing is a vital part of the software development process ensuring the final product to work as expected.
The most basic technique of software testing are unit tests, i.e. testing an individual software component independently.
However, covering a software solely with unit tests can provide false confidence in the product to behave as required.
Especially unit tests for software with SOLID design can fail to detect regressions during development.
This talk aims to provide (i) a sensitizing for this problem and (ii) a possible counter strategy with system tests following principles of behavior driven development.

Software-Testing ist ein wesentlicher Teil des Software-Development-Prozesses, welcher sicherstellt, dass das finale Produkt wie erwartet funktioniert.
Die grundlegendste Technik des Software-Testing sind Unit-Tests, d.h. das Testen einer indivuellen Software-Komponente unabhängig von anderen.
Allerdings kann das Abdecken einer Software ausschließlich mit Unit-Tests falsches Vertrauen dafür erzeugen, dass das Produkt sich verhält wie gefordert.
Insbesondere Unit-Tests für Software mit einem SOLID-Design können daran scheitern, Regressionen während der Entwicklung zu erkennen.
Dieser Vortrag möchte (i) für dieses Problem sensibilisieren und (ii) beispielhaft System-Tests kombiniert mit den Prinzipien des Behavior Driven Development als mögliche Gegenstrategie aufzeigen.
