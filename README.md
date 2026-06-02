# 🟢 Construção de Círculos em C# (Windows Forms)

Projeto desenvolvido para a disciplina do Curso Técnico em Informática do Colégio Técnico Antônio Teixeira Fernandes (Univap), com o objetivo de desenhar círculos e arcos utilizando conceitos de geometria analítica e programação gráfica em C#.

---

## 👨‍💻 Autor

**João Vinícius **

- Curso Técnico em Informática

---

## 📋 Sobre o Projeto

Este projeto foi desenvolvido utilizando **Windows Forms** em C# e tem como finalidade demonstrar a construção de círculos através da plotagem de pontos calculados por funções trigonométricas.

O programa desenha um círculo na tela calculando suas coordenadas a partir do seno e do cosseno, sem utilizar métodos prontos para desenhar círculos.

---

## 🎯 Objetivos

- Aplicar conceitos de geometria analítica.
- Utilizar funções trigonométricas em programação.
- Trabalhar com eventos gráficos do Windows Forms.
- Desenvolver algoritmos para desenho de formas geométricas.

---

## 🛠️ Tecnologias Utilizadas

- C#
- .NET Framework
- Windows Forms
- System.Drawing

---

## 📚 Conceitos Utilizados

### Criação de Cores

```csharp
public Color Cor(int r, int g, int b)
{
    return Color.FromArgb(r, g, b);
}
```

Responsável por gerar uma cor utilizando valores RGB.

---

### Criação da Caneta

```csharp
public Pen CriaCaneta(int r, int g, int b)
{
    return new Pen(Cor(r, g, b), 1);
}
```

Cria uma caneta para desenhar na tela.

---

### Plotagem de Pontos

```csharp
public void PintaPonto(PaintEventArgs e, Pen pen, int x, int y)
{
    e.Graphics.DrawLine(pen, x, y, x + 1, y);
}
```

Desenha um único ponto na tela.

---

### Desenho do Arco ou Círculo

```csharp
public void DesenhaArco(PaintEventArgs e, Pen pen, int xc, int yc, int raio, double ti, double tf)
{
    for (double teta = ti; teta <= tf; teta += 0.01)
    {
        int x = (int)(xc + raio * Math.Cos(teta));
        int y = (int)(yc + raio * Math.Sin(teta));

        PintaPonto(e, pen, x, y);
    }
}
```

O método percorre vários ângulos e calcula os pontos do círculo utilizando funções trigonométricas.

---

## 🧮 Fórmulas Matemáticas

As coordenadas dos pontos são calculadas pelas fórmulas:

### Eixo X

```text
x = xc + raio × cos(θ)
```

### Eixo Y

```text
y = yc + raio × sin(θ)
```

Onde:

| Variável | Descrição |
|-----------|-----------|
| xc | Centro do círculo no eixo X |
| yc | Centro do círculo no eixo Y |
| raio | Raio do círculo |
| θ | Ângulo em radianos |

---

## 🎨 Resultado do Programa

No evento de pintura da janela, o programa desenha um círculo verde:

```csharp
private void Form1_Paint(object sender, PaintEventArgs e)
{
    DesenhaArco(
        e,
        CriaCaneta(0, 255, 0),
        200,
        200,
        100,
        0,
        2 * 3.14
    );
}
```

### Configurações do círculo

- Cor: Verde
- Centro: (200, 200)
- Raio: 100 pixels
- Ângulo inicial: 0 radianos
- Ângulo final: 2π radianos

---

## 🚀 Como Executar

1. Abra o projeto no Visual Studio.
2. Compile a solução (`Ctrl + Shift + B`).
3. Execute o programa (`F5`).
4. A janela será aberta exibindo o círculo desenhado.

---

## 📖 Aprendizados

Durante o desenvolvimento deste projeto foram praticados os seguintes conceitos:

- Programação Orientada a Objetos (POO);
- Eventos do Windows Forms;
- Manipulação de gráficos com `Graphics`;
- Utilização de funções matemáticas;
- Construção de formas geométricas através de algoritmos.

---

## 📄 Licença

Projeto desenvolvido para fins educacionais como atividade do Curso Técnico em Informática do Colégio Técnico Antônio Teixeira Fernandes (Univap).

---

⭐ Caso tenha gostado do projeto, deixe uma estrela no repositório!
