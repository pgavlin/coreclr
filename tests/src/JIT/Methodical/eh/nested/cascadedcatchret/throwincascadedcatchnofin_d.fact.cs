using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_nested_cascadedcatchret_throwincascadedcatchnofin_d_throwincascadedcatchnofin_d_
    {
        [Fact]
        public void _eh_nested_cascadedcatchret_throwincascadedcatchnofin_d_throwincascadedcatchnofin_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\cascadedcatchret\\throwincascadedcatchnofin_d\\throwincascadedcatchnofin_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
