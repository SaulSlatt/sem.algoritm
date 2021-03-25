/*
 * Created by SharpDevelop.
 * User: DIANA
 * Date: 16/03/2021
 * Time: 05:20 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Circulos
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		
		}
		
		
		void Button1Click(object sender, EventArgs e)
		{
			openFileDialog1.ShowDialog();
			pictureBoximage.Image = Image.FromFile(openFileDialog1.FileName);
		}
		
		class objetocirculo{
		//public:
			int radio;
			int x;
			int y;
			int diametro;
		};
		
		void ButtonAnalizarClick(object sender, EventArgs e)
		{
			int x=0,y=0;
			
			
			Bitmap bmpcentro = new Bitmap(openFileDialog1.FileName);
			Color colory;
			pictureBoximage.Image = bmpcentro;
			colory=bmpcentro.GetPixel(x,y );
				for( x=0; x < bmpcentro.Height; x++)
					for( y=0; y < bmpcentro.Width; y++){//recorrer todos los pixeles
					
					if(colory.R!=255 && colory.G!=255&&colory.B!=255){//verificar que no sea blanco
		                 BuscaCentro(x,y,bmpcentro);
					}
		
		}
		}
		
		
		void BuscaCentro(int x,int y,Bitmap image){
		int yi,xi,yf,xf;
		int yc=0,xc=0;
		Color pixcol;
		pixcol=image.GetPixel(x,y);
				       yi=y;//Y inicial
				       yf=y;//y final
				       while(pixcol.R!=255 && pixcol.G!=255&& pixcol.B!=255){
				       	  pixcol=image.GetPixel(x,yf);
				      	  yf++;
				      	  
						}
						
				       yc=(yi+yf)/2;//y centro
						
						xi=x;
						xf=x;
						while(pixcol.R!=255 && pixcol.G!=255&& pixcol.B!=255){
							pixcol=image.GetPixel(x,yc);
							xi--;
							
						}
						//x inicial
						while(pixcol.R!=255 && pixcol.G!=255&& pixcol.B!=255){
							pixcol=image.GetPixel(x,yc);
							xf++;
						}
						//x final
						xc=(xi+xf)/2;//x central
						
						
					//}
					
				
				 
				
				label1.Text = ("Centro: "+xc.ToString()+ ","+yc.ToString());
				
				//int i =  xi;
				//int j = yi;
				
			
		}//point
		
		
		
		void dibujacirculo(int f,int c){
			
		}
	
		

	}
}
/*

			Bitmap bmp = new Bitmap(openFileDialog1.FileName);
			Color colorActual;
			pictureBoximage.Image = bmp;
			
			for(int i=0; i < bmp.Height; i++)
				for(int j=0; j < bmp.Width; j++){
				
				   colorActual = bmp.GetPixel(j,i);
			       if(colorActual.R!=255)
			          if(colorActual.G!=255)
					     if(colorActual.B!=255)
						    bmp.SetPixel(j,i,Color.Blue);
			}
		*/	