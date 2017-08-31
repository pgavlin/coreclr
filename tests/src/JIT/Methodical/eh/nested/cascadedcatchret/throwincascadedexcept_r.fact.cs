using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_nested_cascadedcatchret_throwincascadedexcept_r_throwincascadedexcept_r_
    {
        [Fact]
        public void _eh_nested_cascadedcatchret_throwincascadedexcept_r_throwincascadedexcept_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\cascadedcatchret\\throwincascadedexcept_r\\throwincascadedexcept_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
