using System;

class Program {
  public static void Main (string[] args) {
    //circle
    Circle c1 = new Circle(0);
    for(int i = 1; i < 11; i++){
      c1.setRadius((double) i);
      Console.WriteLine("Area of a circle with radius "+i+" is "+c1.area()+" circumference is "+ c1.circumference());
      Console.WriteLine("");
    }
    //Rectangle
    Rectangle r1 = new Rectangle(0, 0);
    for(int i = 1; i < 4; i++){
      for(int j = 1; j < 4; j++){
        r1.setH_W((double) i, (double) j);
        Console.WriteLine("Area of a rectangle "+i+" by "+j+" is "+r1.area()+" and it's perimeter is "+ r1.perimeter());
        Console.WriteLine("");
      }
    }
    //Triangle
    Triangle t1 = new Triangle(18,30,24);
    //default Triangle 
    Triangle t2 = new Triangle();
    //triangle being printed in current itteration
    //just placeholder to make neater
    Triangle t3 = t1;
    for(int i = 1; i < 3; i++){
    if(i == 2){
      //update t3 to t2 to reprint the triangles info with the default values
      t3 = t2;
    }
      Console.WriteLine("Area of a triangle "+t3.getSide1()+ "x"+t3.getSide2()+"x"+t3.getSide3() + " is "+t3.area()+" it's perimeter is "+t3.perimeter()+" and it's height is "+t3.height());
      Console.WriteLine(" ");
    } 
  }
}

public class Circle {
  private double Radius;
  public Circle(double radius){
    this.Radius = radius;
  }
  public double circumference (){
    return (2 * Math.PI * Radius);
  }
  public double area(){
    return (Math.PI * Math.Pow(Radius , 2));
  }
  public void setRadius(double i){
    Radius = i;
  }
}
public class Triangle {
  private double S1;
  private double S2;
  private double S3;
  //default
  public Triangle(){
  this.S1 = 3;
  this.S2 = 4;
  this.S3 = 5;
  }
  public double getSide1(){
    return S1;
  }
  public double getSide2(){
    return S2;
  }
  public double getSide3(){
    return S3;
  }
  public Triangle(double s1, double s2, double s3){
    this.S1 = s1;
    this.S2 = s2;
    this.S3 = s3;
  }
  public double perimeter(){
    return S1 + S2 + S3;
  }
  public double area(){
    double p = perimeter()/2;
    return Math.Sqrt(p * (p - S1)*(p - S2)*(p - S3));
  }
  public double height(){
    double smallSide = S1;
    if(smallSide > S2){
      smallSide = S2;
    }
    if(smallSide > S3){
      smallSide = S3;
    }
    return (area()*2)/smallSide;
  }
  public override string ToString(){
    return "Triangle has sides "+S1+", "+S2+" and "+S3+". It has an area of "+area()+", a perimeter of "+perimeter()+ ", and a height of " + height();
  }
}
public class Rectangle{
  private double rHeight;
  private double rWidth;
  public Rectangle(double rheight, double rwidth){
    this.rHeight = rheight;
    this.rWidth = rwidth;
  }
  public void setH_W(double i, double j){
    rHeight = i;
    rWidth = j;
  }
  public double perimeter(){
    return (2 * rHeight) + (2 * rWidth);
  }
  public double area(){
    return rHeight * rWidth;
  }
}
