using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _v1_Beta1_Layout_Matrix_cs_L_1_11_3_L_1_11_3_
    {
        [OuterLoop]
        [Fact]
        public void _v1_Beta1_Layout_Matrix_cs_L_1_11_3_L_1_11_3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\v1\\Beta1\\Layout\\Matrix\\cs\\L-1-11-3\\L-1-11-3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
