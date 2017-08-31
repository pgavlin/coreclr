using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _SequentialLayout_Regress_217070_t1_t1_
    {
        [Fact]
        public void _SequentialLayout_Regress_217070_t1_t1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\SequentialLayout\\Regress\\217070\\t1\\t1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
