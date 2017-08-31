using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_nested_cascadedcatchret_cascadedexcept_d_cascadedexcept_d_
    {
        [Fact]
        public void _eh_nested_cascadedcatchret_cascadedexcept_d_cascadedexcept_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\cascadedcatchret\\cascadedexcept_d\\cascadedexcept_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
