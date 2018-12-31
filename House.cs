namespace Classwork
{
    public class House
    {
        // The following are fields
        string _foundation;
       // string _roof;
        string _window;
        string _door; 
      

      public string Foundation
      {
          get 
          {
              return _foundation; 
            
          }
          set 
          {
              this._foundation = value;
          }
      }

      public string Roof {get; set;}
      public string PaintDoor {get; set;}
      public string Window 
      {
          get{
              return _window ;
          }
          set{
              this._window = value ; 
          }
      }
        //The following are methods 
        public void OpenDoor()
        {

        }

        public void CloseDoor()
        {

        }


    }
}