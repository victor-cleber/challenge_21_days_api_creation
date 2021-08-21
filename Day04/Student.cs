using System;

namespace Day03{
    public class Student{
        string _name;
        
        public string Name{
            get{
                return this._name.ToLower();
            }
            set{
                this._name = _name.ToUpper();
            }
        }
        
        public string StudentId {get; set;}

        public List<double> Grades{get; set;}
           
        private double CalculateScore(){
            var sumGrades = 0.0;
            foreach (var nota in this.Grades){
                sumGrades += nota;
            }
            return sumGrades / this.Grades.Count;
        }
        
        public string Status (){
            return this.CalculateScore() >= 7 ? "Approved": "Failed";
        }
    }
}