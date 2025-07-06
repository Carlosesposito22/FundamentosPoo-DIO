# Abstração de Celulares com .NET - Programação Orientada a Objetos

Este projeto, desenvolvido como parte da **trilha .NET da DIO**, tem como objetivo modelar um sistema de celulares utilizando os princípios da **Programação Orientada a Objetos (POO)**. O foco foi criar uma estrutura flexível que permite a representação de diferentes marcas e modelos de celulares, promovendo o **reuso de código** e a **extensibilidade**.

---

## Sobre o Projeto

O sistema é um aplicativo de console simples em C# que simula a funcionalidade básica de smartphones, como fazer ligações, receber ligações e instalar aplicativos. A principal característica é a implementação de **herança** e **polimorfismo** para lidar com as particularidades de diferentes marcas.

As classes chave incluem:

* **`Smartphone` (Classe Abstrata):** Serve como um modelo base para todos os celulares. Ela define as características e comportamentos comuns que qualquer smartphone deve ter, mas não pode ser instanciada diretamente. Isso garante que a funcionalidade básica seja consistente, mas permite que as especificidades de cada marca sejam implementadas em suas classes filhas.

* **`Nokia` (Classe Concreta):** Representa um celular da marca Nokia. Herda de `Smartphone` e implementa os métodos abstratos e sobrescreve o método `InstalarAplicativo` para refletir a maneira como um Nokia instalaria um aplicativo.

* **`Iphone` (Classe Concreta):** Representa um celular da marca iPhone. Assim como o Nokia, herda de `Smartphone` e sobrescreve o método `InstalarAplicativo` para simular o processo de instalação em um iPhone.

---

## O que Aprendemos

Ao desenvolver este projeto, pude consolidar e aprofundar meus conhecimentos nos seguintes conceitos de Orientação a Objetos em .NET:

* **Classes e Objetos:** Reforcei a criação e manipulação de classes para modelar entidades do mundo real (celulares) e a criação de objetos a partir dessas classes.

* **Abstração:** Entendi a importância de **classes abstratas** (`Smartphone`) para definir um contrato comum e ocultar detalhes de implementação, focando apenas no que é relevante. Isso permitiu que o código fosse mais genérico e flexível.

* **Herança:** Apliquei o conceito de **herança** para criar classes mais específicas (`Nokia`, `Iphone`) que reutilizam o código e o comportamento da classe base (`Smartphone`), evitando duplicação e facilitando a manutenção.

* **Polimorfismo:** Explorei o **polimorfismo** ao sobrescrever o método `InstalarAplicativo` nas classes `Nokia` e `Iphone`. Embora ambos os celulares possam "instalar um aplicativo", a forma como o fazem é diferente, e o polimorfismo permite que chamemos o mesmo método com comportamentos distintos, dependendo do tipo de objeto.
