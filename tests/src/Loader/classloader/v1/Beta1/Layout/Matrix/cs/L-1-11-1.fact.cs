using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _v1_Beta1_Layout_Matrix_cs_L_1_11_1_L_1_11_1_
    {
        [OuterLoop]
        [Fact]
        public void _v1_Beta1_Layout_Matrix_cs_L_1_11_1_L_1_11_1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\v1\\Beta1\\Layout\\Matrix\\cs\\L-1-11-1\\L-1-11-1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
