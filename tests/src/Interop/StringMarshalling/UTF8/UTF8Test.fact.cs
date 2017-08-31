using CoreclrTestLib;
using Xunit;

namespace Interop_StringMarshalling
{
    class _UTF8_UTF8Test_UTF8Test_
    {
        [OuterLoop]
        [Fact]
        public void _UTF8_UTF8Test_UTF8Test_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Interop\\StringMarshalling\\UTF8\\UTF8Test\\UTF8Test.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
