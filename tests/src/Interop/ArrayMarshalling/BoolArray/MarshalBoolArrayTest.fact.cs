using CoreclrTestLib;
using Xunit;

namespace Interop_ArrayMarshalling
{
    public class _BoolArray_MarshalBoolArrayTest_MarshalBoolArrayTest_
    {
        [OuterLoop]
        [Fact]
        public void _BoolArray_MarshalBoolArrayTest_MarshalBoolArrayTest_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Interop\\ArrayMarshalling\\BoolArray\\MarshalBoolArrayTest\\MarshalBoolArrayTest.cmd");
        }
    }
}
