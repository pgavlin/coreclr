using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_nested_cascadedcatchret_throwincascadedcatchnofin_r_throwincascadedcatchnofin_r_
    {
        [Fact]
        public void _eh_nested_cascadedcatchret_throwincascadedcatchnofin_r_throwincascadedcatchnofin_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\cascadedcatchret\\throwincascadedcatchnofin_r\\throwincascadedcatchnofin_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
