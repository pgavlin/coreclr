using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _SequentialLayout_Regress_217070_t2_t2_
    {
        [OuterLoop]
        [Fact]
        public void _SequentialLayout_Regress_217070_t2_t2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\SequentialLayout\\Regress\\217070\\t2\\t2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
