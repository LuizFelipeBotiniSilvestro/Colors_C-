using System;
using System.Drawing;


public class Efeitos	{


	public Bitmap gride(Bitmap tempBm){

		Bitmap bm = new Bitmap(tempBm);


		Color c = new Color();
		c = Color.FromArgb(0,0,0);


		for (int i = 0; i < bm.Width; i+=4){

			for (int j = 0; j < bm.Height; j+=4){

				bm.SetPixel(i,j,c);
			}

		}			

		return bm;


	}

	public Bitmap vermelho(Bitmap tempBm){

		Bitmap bm = new Bitmap(tempBm);
		Color colorPx ;

		for (int i = 0; i < bm.Width; i++){

			for (int j = 0; j < bm.Height; j++){
				
				colorPx = bm.GetPixel(i,j);
				int pixelR = 0;
				int pixelG = 0;
				int pixelB = 0;

				pixelR = colorPx.R;
				pixelG = colorPx.G - 255;
				pixelB = colorPx.B - 255;

				pixelR = Math.Max(pixelR, 0);
				pixelR = Math.Min(255, pixelR);


		
				pixelG = Math.Max(pixelG, 0);
				pixelG = Math.Min(255, pixelG);

			
				pixelB = Math.Max(pixelB, 0);
				pixelB = Math.Min(255, pixelB);			


				bm.SetPixel(i,j,Color.FromArgb((byte)pixelR, (byte)pixelG, (byte)pixelB));
			}

		}			

		return bm;

	}

	public Bitmap verde(Bitmap tempBm){

		Bitmap bm = new Bitmap(tempBm);
		Color colorPx ;

		for (int i = 0; i < bm.Width; i++){

			for (int j = 0; j < bm.Height; j++){

				colorPx = bm.GetPixel(i,j);
				int pixelR = 0;
				int pixelG = 0;
				int pixelB = 0;

				pixelR = colorPx.R - 255;
				pixelG = colorPx.G ;
				pixelB = colorPx.B - 255;

				pixelR = Math.Max(pixelR, 0);
				pixelR = Math.Min(255, pixelR);


				pixelG = Math.Max(pixelG, 0);
				pixelG = Math.Min(255, pixelG);

				pixelB = Math.Max(pixelB, 0);
				pixelB = Math.Min(255, pixelB);					

				bm.SetPixel(i,j,Color.FromArgb((byte)pixelR, (byte)pixelG, (byte)pixelB));
			}

		}			

		return bm;


	}

	public Bitmap azul(Bitmap tempBm){

		Bitmap bm = new Bitmap(tempBm);
		Color colorPx ;

		for (int i = 0; i < bm.Width; i++){

			for (int j = 0; j < bm.Height; j++){

				colorPx = bm.GetPixel(i,j);
				int pixelR = 0;
				int pixelG = 0;
				int pixelB = 0;

				pixelR = colorPx.R - 255;
				pixelG = colorPx.G - 255;
				pixelB = colorPx.B;		

				pixelR = Math.Max(pixelR, 0);
				pixelR = Math.Min(255, pixelR);

				pixelG = Math.Max(pixelG, 0);
				pixelG = Math.Min(255, pixelG);

				pixelB = Math.Max(pixelB, 0);
				pixelB = Math.Min(255, pixelB);

				bm.SetPixel(i, j, Color.FromArgb((byte)pixelR, (byte)pixelG, (byte)pixelB));
			}

		}			

		return bm;


	}

	public Bitmap cinza(Bitmap tempBm)
	{

		Bitmap bm = new Bitmap(tempBm);
		Color colorPx;

		for (int i = 0; i < bm.Width; i++)
		{

			for (int j = 0; j < bm.Height; j++)
			{


				colorPx = bm.GetPixel(i, j);
				int pixelR = 0;
				int pixelG = 0;
				int pixelB = 0;

				pixelR = colorPx.R;
				pixelG = colorPx.G;
				pixelB = colorPx.B;

				float media = (pixelR + pixelG + pixelB) / 3;
				int m = (int)media;

				pixelR = Math.Max(pixelR, 0);
				pixelR = Math.Min(255, pixelR);

				pixelG = Math.Max(pixelG, 0);
				pixelG = Math.Min(255, pixelG);

				pixelB = Math.Max(pixelB, 0);
				pixelB = Math.Min(255, pixelB);

				bm.SetPixel(i, j, Color.FromArgb((byte)m, (byte)m, (byte)m));
				
			}

		}

		return bm;


	}

	public Bitmap PretoBranco(Bitmap tempBm)
	{

		Bitmap bm = new Bitmap(tempBm);
		Color colorPx;

		for (int i = 0; i < bm.Width; i++)
		{

			for (int j = 0; j < bm.Height; j++)
			{


				colorPx = bm.GetPixel(i, j);
				int pixelR = 0;
				int pixelG = 0;
				int pixelB = 0;

				pixelR = colorPx.R;
				pixelG = colorPx.G;
				pixelB = colorPx.B;

				float media = (pixelR + pixelG + pixelB) / 3;
				int m = (int)media;

				pixelR = Math.Max(pixelR, 0);
				pixelR = Math.Min(255, pixelR);

				pixelG = Math.Max(pixelG, 0);
				pixelG = Math.Min(255, pixelG);

				pixelB = Math.Max(pixelB, 0);
				pixelB = Math.Min(255, pixelB);

				bm.SetPixel(i, j, Color.FromArgb((byte)m, (byte)m, (byte)m));

			}

		}

		return bm;


	}


}
