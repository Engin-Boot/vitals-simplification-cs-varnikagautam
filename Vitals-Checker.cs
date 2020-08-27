using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace VitalsSimplification
{
  class VitalsChecker
  {
      static bool vitalsAreOk(float bpm, float spo2, float respRate) 
      {
          if(bpm < 70 || bpm > 150) {
              return false;
          } else if(spo2 < 90) {
              return false;
          } else if(respRate < 30 || respRate > 95) {
              return false;
          }
          return true;
      }
   }
}
