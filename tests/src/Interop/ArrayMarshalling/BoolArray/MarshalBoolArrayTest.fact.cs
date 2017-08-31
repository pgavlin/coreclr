using CoreclrTestLib;
using Xunit;

namespace Interop_ArrayMarshalling
{
    class _BoolArray_MarshalBoolArrayTest_MarshalBoolArrayTest_
    {
        [OuterLoop]
        [Fact]
        public void _BoolArray_MarshalBoolArrayTest_MarshalBoolArrayTest_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Interop\\ArrayMarshalling\\BoolArray\\MarshalBoolArrayTest\\MarshalBoolArrayTest.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
