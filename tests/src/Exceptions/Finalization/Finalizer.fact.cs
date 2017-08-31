using CoreclrTestLib;
using Xunit;

namespace Exceptions_Finalization
{
    class _Finalizer_Finalizer_
    {
        [Fact]
        public void _Finalizer_Finalizer_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Exceptions\\Finalization\\Finalizer\\Finalizer.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
