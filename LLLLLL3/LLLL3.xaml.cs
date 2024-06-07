using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LLLLLL3
{
    public partial class LLLL3 : UserControl
    {
        public Viewport3D myViewport3D = new Viewport3D();
        public PerspectiveCamera myPCamera = new PerspectiveCamera();
        public LLLL3()
        {
            myPCamera.Position = new Point3D(3, 4, 15);
            myPCamera.LookDirection = new Vector3D(-3, -4, -15);
            myPCamera.UpDirection = new Vector3D(0, 1, 0);
            myPCamera.FieldOfView = 80;
            myViewport3D.Camera = myPCamera;
            Model3DGroup myModel3DGroup = new Model3DGroup();
            AmbientLight ambient = new AmbientLight(Colors.White);
            myModel3DGroup.Children.Add(ambient);
            myModel3DGroup.Children.Add(Cubik());
            myModel3DGroup.Children.Add(AxisY());
            myModel3DGroup.Children.Add(AxisX());
            myModel3DGroup.Children.Add(AxisZ());
            ModelVisual3D visual = new ModelVisual3D();
            visual.Content = myModel3DGroup;
            myViewport3D.Children.Add(visual);
        }
        public GeometryModel3D Cubik()
        {
            MeshGeometry3D mesh7 = new MeshGeometry3D();
            mesh7.Positions.Add(new Point3D(-1, -1, -1));
            mesh7.Positions.Add(new Point3D(-1, 1, -1));
            mesh7.Positions.Add(new Point3D(-1, 1, 1));
            mesh7.Positions.Add(new Point3D(-1, -1, 1));
            mesh7.Positions.Add(new Point3D(1, -1, -1));
            mesh7.Positions.Add(new Point3D(1, 1, -1));
            mesh7.Positions.Add(new Point3D(1, 1, 1));
            mesh7.Positions.Add(new Point3D(1, -1, 1));
            mesh7.TriangleIndices.Add(0);
            mesh7.TriangleIndices.Add(1);
            mesh7.TriangleIndices.Add(2);
            mesh7.TriangleIndices.Add(0);
            mesh7.TriangleIndices.Add(2);
            mesh7.TriangleIndices.Add(3);
            mesh7.TriangleIndices.Add(0);
            mesh7.TriangleIndices.Add(4);
            mesh7.TriangleIndices.Add(5);
            mesh7.TriangleIndices.Add(0);
            mesh7.TriangleIndices.Add(5);
            mesh7.TriangleIndices.Add(1);
            mesh7.TriangleIndices.Add(4);
            mesh7.TriangleIndices.Add(5);
            mesh7.TriangleIndices.Add(7);
            mesh7.TriangleIndices.Add(7);
            mesh7.TriangleIndices.Add(5);
            mesh7.TriangleIndices.Add(6);
            mesh7.TriangleIndices.Add(3);
            mesh7.TriangleIndices.Add(7);
            mesh7.TriangleIndices.Add(6);
            mesh7.TriangleIndices.Add(3);
            mesh7.TriangleIndices.Add(6);
            mesh7.TriangleIndices.Add(2);
            mesh7.TriangleIndices.Add(5);
            mesh7.TriangleIndices.Add(1);
            mesh7.TriangleIndices.Add(2);
            mesh7.TriangleIndices.Add(5);
            mesh7.TriangleIndices.Add(2);
            mesh7.TriangleIndices.Add(6);
            mesh7.TriangleIndices.Add(7);
            mesh7.TriangleIndices.Add(4);
            mesh7.TriangleIndices.Add(3);
            mesh7.TriangleIndices.Add(3);
            mesh7.TriangleIndices.Add(4);
            mesh7.TriangleIndices.Add(0);
            DiffuseMaterial myMaterial7 = new DiffuseMaterial(new SolidColorBrush(Colors.Gray));
            GeometryModel3D model7 = new GeometryModel3D(mesh7, myMaterial7);
            model7.BackMaterial = myMaterial7;
            return model7;

        }
        public GeometryModel3D AxisZ()
        {
            MeshGeometry3D mesh2 = new MeshGeometry3D();
            mesh2.Positions.Add(new Point3D(-0.02, -2, 0));
            mesh2.Positions.Add(new Point3D(0.02, -2, 0));
            mesh2.Positions.Add(new Point3D(-0.02, 2, 0));
            mesh2.Positions.Add(new Point3D(0.02, 2, 0));
            mesh2.TriangleIndices.Add(1);
            mesh2.TriangleIndices.Add(0);
            mesh2.TriangleIndices.Add(2);
            mesh2.TriangleIndices.Add(1);
            mesh2.TriangleIndices.Add(2);
            mesh2.TriangleIndices.Add(3);
            DiffuseMaterial myMaterial3 = new DiffuseMaterial(new SolidColorBrush(Colors.Blue));
            GeometryModel3D model2 = new GeometryModel3D(mesh2, myMaterial3);
            model2.BackMaterial = myMaterial3;
            return model2;
        }
        public GeometryModel3D AxisX()
        {
            MeshGeometry3D mesh5 = new MeshGeometry3D();
            mesh5.Positions.Add(new Point3D(-2, 0, -0.02));
            mesh5.Positions.Add(new Point3D(-2, 0, 0.02));
            mesh5.Positions.Add(new Point3D(2, 0, -0.02));
            mesh5.Positions.Add(new Point3D(2, 0, 0.02));
            mesh5.TriangleIndices.Add(1);
            mesh5.TriangleIndices.Add(0);
            mesh5.TriangleIndices.Add(2);
            mesh5.TriangleIndices.Add(1);
            mesh5.TriangleIndices.Add(2);
            mesh5.TriangleIndices.Add(3);
            DiffuseMaterial myMaterial3 = new DiffuseMaterial(new SolidColorBrush(Colors.Red));
            GeometryModel3D model5 = new GeometryModel3D(mesh5, myMaterial3);
            model5.BackMaterial = myMaterial3;
            return model5;
        }
        public GeometryModel3D AxisY()
        {
            MeshGeometry3D mesh4 = new MeshGeometry3D();
            mesh4.Positions.Add(new Point3D(-0.02, 0, -2));
            mesh4.Positions.Add(new Point3D(0.02, 0, -2));
            mesh4.Positions.Add(new Point3D(-0.02, 0, 2));
            mesh4.Positions.Add(new Point3D(0.02, 0, 2));
            mesh4.TriangleIndices.Add(1);
            mesh4.TriangleIndices.Add(0);
            mesh4.TriangleIndices.Add(2);
            mesh4.TriangleIndices.Add(1);
            mesh4.TriangleIndices.Add(2);
            mesh4.TriangleIndices.Add(3);
            DiffuseMaterial myMaterial3 = new DiffuseMaterial(new SolidColorBrush(Colors.LimeGreen));
            GeometryModel3D model4 = new GeometryModel3D(mesh4, myMaterial3);
            model4.BackMaterial = myMaterial3;
            return model4;
        }
    }
}

