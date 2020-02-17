//***************************************************************************************
// ICA05
// Ryan LeBlanc
// CNTA03
// Kevin Moore
//***************************************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;

namespace ICA05
{
    public partial class Form1 : Form
    {
        private bool _border = false;       // true if border to be drawn
        private int _jumpDistance = 1;      // multiplier for distance between circles
        private CDrawer _canvas;            // GDI canvas
        private Color _circle = new Color();        // Colour for circles
        private Point _toDraw = new Point();
        
        public Form1()
        {
            InitializeComponent();
        }

        // Form loads
        // _todraw and _circle are set to their presets
        private void Form1_Load(object sender, EventArgs e)
        {
            // Set Presets
            _toDraw.X = 15; _toDraw.Y = 15;
            _canvas = new CDrawer(600,600);
            _canvas.Scale = 20;
            _circle = Color.Red;
            //Draw first
            DrawCircle(_toDraw, _circle);
        }

        // a key is pressed
        // _border is enbled
        // _jumpDistance can be altered
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // check if distance and border controls are activeley being depressed
            // and changes the setting appropriately
            if (e.Shift)
                // distances are changed
                _jumpDistance = 2;
            else if (e.Control)
                _jumpDistance = 3;
            else if (e.Alt)
                _jumpDistance = 4;
            else
                _jumpDistance = 1;
            // border is enabled
            if (e.KeyCode == Keys.F1)
                _border = true;
            
                
            // check for key commands
            switch (e.KeyCode)
            {
                case Keys.Up:       //up key
                    // draw a circle above the current position 
                    _toDraw.Y = _toDraw.Y - _jumpDistance;
                    if (_toDraw.Y < 0)
                        _toDraw.Y = 0;
                    DrawCircle(_toDraw, _circle);
                    break;
                case Keys.Down:       //down key
                    // draw a circle below the current position 
                    _toDraw.Y = _toDraw.Y + _jumpDistance;
                    if (_toDraw.Y > 600)
                        _toDraw.Y = 600;
                    DrawCircle(_toDraw, _circle);
                    break;
                case Keys.Left:       //left key
                    // draw a circle to the left of the current position 
                    _toDraw.X = _toDraw.X - _jumpDistance;
                    if (_toDraw.X < 0)
                        _toDraw.X = 0;
                    DrawCircle(_toDraw, _circle);
                    break;
                case Keys.Right:       //right key
                    // draw a circle to the right of the current position 
                    _toDraw.X = _toDraw.X + _jumpDistance;
                    if (_toDraw.X > 600)
                        _toDraw.X = 600;
                    DrawCircle(_toDraw, _circle);
                    break;
                case Keys.B:        // b button
                    // change drawing color blue
                    _circle = Color.Blue;
                    break;
                case Keys.R:        // r button
                    // change drawing color red
                    _circle = Color.Red;
                    break;
                case Keys.G:        // g button
                    // change drawing color green
                    _circle = Color.Green;
                    break;
                case Keys.X:        // x button
                    // close program
                    Close();
                    break;
                default:
                    break;
            }
        }
        // Key is released
        // disables _border
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //check if F1 released
            if (e.KeyCode == Keys.F1)
                //disable _border
                _border = false;
        }
        //*******************************************************************************************************
        // Method:      private void DrawCircle(Point toDraw, Color cirColour)
        // Purpose:     draw circle
        // Parameters:  Point toDraw    - point to draw circle
        //              Color cirColour - colour to draw circle
        // Returns:     none - draws a circle
        //*******************************************************************************************************
        private void DrawCircle(Point toDraw, Color cirColour)
        {
            // check if we want a border then draw the appropriate circle
            if(!_border)
                _canvas.AddCenteredEllipse(toDraw, 1, 1, cirColour);
            else
                _canvas.AddCenteredEllipse(toDraw, 1, 1, cirColour, 1, Color.White);
        }

        
    }
}
