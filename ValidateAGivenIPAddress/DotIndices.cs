using System;
using System.Collections.Generic;
using System.Text;

namespace ValidateAGivenIPAddress
{
    class DotIndices
    {
        int FirstIndex;

        int SecondIndex;

        int ThirdIndex;

        String StringUntilFirstIndex;

        String StringFromFirstTillSecondIndex;

        String StringFromSecondUntilThirdIndex;
        
        String FourthString;

        bool isFirstValidated;

        bool isSecondValidated;

        bool isThirdValidated;

        bool isFourthValidated;
        public DotIndices() { }

        public void SetFirstIndex(int index) {
            FirstIndex = index;
        }

        public void SetSecondIndex(int index)
        {
            SecondIndex = index;
        }

        public void SetThirdIndex(int index)
        {
            ThirdIndex = index;
        }

        public void SetFirstString(string firstString)
        {
            StringUntilFirstIndex = firstString;
        }

        public void SetSecondString(string secondString)
        {
            StringFromFirstTillSecondIndex = secondString;
        }
        public void SetThirdString(string thirdString)
        {
            StringFromSecondUntilThirdIndex = thirdString;
        }

        public String GetFirstString() {
            return StringUntilFirstIndex;
        }

        public String GetSecondString() {
            return StringFromFirstTillSecondIndex;
        }

        public String GetThirdString() {
            return StringFromSecondUntilThirdIndex;
        }

        public int GetFirstIndex() {
            return FirstIndex;
        }

        public int GetSecondIndex() {
            return SecondIndex;
        }

        public int GetThirdIndex() {
            return ThirdIndex;
        }

        public String GetFourthString()
        {
            return FourthString;
        }

        public void SetFourthString(String lastString)
        {
            FourthString = lastString;
        }


        public bool GetFirstValidation()
        {
            return isFirstValidated;
        }

        public bool GetSecondValidation() {
            return isSecondValidated;
        }

        public bool GetThirdValidation() {
            return isThirdValidated;
        }

        public bool GetFourthValidated()
        {
            return isFourthValidated;
        }

        public void SetFirstValidation(bool result) {
            isFirstValidated = result;
        }

        public void SetSecondValidation(bool result)
        {
            isSecondValidated = result;
        }

        public void SetThirdValidation(bool result)
        {
            isThirdValidated = result;
        }

        public void SetFourthValidation(bool result)
        {
            isFourthValidated = result;
        }
    }
}
