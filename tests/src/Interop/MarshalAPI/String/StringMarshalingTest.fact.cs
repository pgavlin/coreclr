using CoreclrTestLib;
using Xunit;

namespace Interop_MarshalAPI
{
    class _String_StringMarshalingTest_StringMarshalingTest_
    {
        [OuterLoop]
        [Fact]
        public void _String_StringMarshalingTest_StringMarshalingTest_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Interop\\MarshalAPI\\String\\StringMarshalingTest\\StringMarshalingTest.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
