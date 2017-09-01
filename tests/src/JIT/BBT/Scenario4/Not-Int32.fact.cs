using CoreclrTestLib;
using Xunit;

namespace JIT_BBT
{
    public class _Scenario4_Not_Int32_Not_Int32_
    {
        [OuterLoop]
        [Fact]
        public void _Scenario4_Not_Int32_Not_Int32_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\BBT\\Scenario4\\Not-Int32\\Not-Int32.cmd");
        }
    }
}
