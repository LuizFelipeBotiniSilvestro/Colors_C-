using System;
using System.Windows.Forms;
using System.Drawing;


public class Janela : Form {

	public PictureBox pbOriginal;
	public PictureBox pbEfeito;
	public Bitmap bm;
	public Efeitos fx;

	static public void Main(){

		Application.Run(new Janela());

	}


	public Janela (){

		fx = new Efeitos();
		Text = "Minha Janela"; 
			
		this.Size = new Size(800,500);
		AddBotoes();
		carregarImgOriginal();
		carregarImgModificada();

	}

	public void carregarImgOriginal(){
									
		pbOriginal = new PictureBox();
		pbOriginal.Image = Image.FromFile("cachorro.jpg");
		pbOriginal.Location = new Point(20, 100);
		pbOriginal.Size = new Size(350, 350);
		this.Controls.Add(pbOriginal);
		bm = new Bitmap(pbOriginal.Image);


	}

	public void carregarImgModificada(){

		pbEfeito= new PictureBox();
		pbEfeito.Image = Image.FromFile("cachorro.jpg");
		pbEfeito.Location = new Point(400, 100);
		pbEfeito.Size = new Size(650, 350);
		this.Controls.Add(pbEfeito);

	}

	

	private void AddBotoes(){

	//	Botao Gride
		Button btA = new Button();	
		btA.Text = "Efeito Grid";
		btA.Size = new Size(120,40);
		btA.Location = new Point (20,10);
		btA.UseVisualStyleBackColor = true;
		btA.Click += new EventHandler(this.addGride);
		this.Controls.Add(btA);

	//	Botao Cor Vermelha
		Button btB = new Button();	
		btB.Text = "Vermelho";
		btB.Size = new Size(120,40);
		btB.Location = new Point (150,10);
		btB.UseVisualStyleBackColor = true;
		btB.Click += new EventHandler(this.addVermelho);
		this.Controls.Add(btB);

	//	Botao Cor Verde
		Button btC = new Button();	
		btC.Text = "Verde";
		btC.Size = new Size(120,40);
		btC.Location = new Point (280,10);
		btC.UseVisualStyleBackColor = true;
		btC.Click += new EventHandler(this.addVerde);
		this.Controls.Add(btC);

	//	Botao Cor Azul
		Button btD = new Button();	
		btD.Text = "Azul";
		btD.Size = new Size(120,40);
		btD.Location = new Point (410, 10);
		btD.UseVisualStyleBackColor = true;
		btD.Click += new EventHandler(this.addAzul);
		this.Controls.Add(btD);

		// Botão Cor cinza   cinza
		Button btCz = new Button();
		btCz.Text = "Cinza";
		btCz.Size = new Size(120, 40);
		btCz.Location = new Point(540, 10);
		btCz.UseVisualStyleBackColor = true;
		btCz.Click += new EventHandler(this.addCinza);
		this.Controls.Add(btCz);

		// Botão Cor Preto e branco
		Button btPrBr = new Button();
		btPrBr.Text = "Preto/Branco";
		btPrBr.Size = new Size(120, 40);
		btPrBr.Location = new Point(670, 10);
		btPrBr.UseVisualStyleBackColor = true;
		btPrBr.Click += new EventHandler(this.addPretoBranco);
		this.Controls.Add(btPrBr);
	}

	public void addGride(Object sender, EventArgs e){
		
		pbEfeito.Image = fx.gride(bm);

	}

	public void addVermelho(Object sender, EventArgs e){
		
		pbEfeito.Image = fx.vermelho(bm);

	}

	public void addVerde(Object sender, EventArgs e){

		pbEfeito.Image = fx.verde(bm);

	}


	public void addAzul(Object sender, EventArgs e){

		pbEfeito.Image = fx.azul(bm);

	}

	public void addCinza(Object sender, EventArgs e)
    {
		pbEfeito.Image = fx.cinza(bm);
    }

	public void addPretoBranco(Object sender, EventArgs e)
	{
		pbEfeito.Image = fx.cinza(bm);
	}

}

