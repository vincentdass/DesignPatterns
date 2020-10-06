using System;
public class Publisher
{
      public List<Subsciber> Subscribers;
      Publisher()
      {
          Suscribers = new List<Subscriber>();
      }
      
      public void Subscribe(Subscriber sub)
      {
          Subscribers.add(sub);
      }
}
