using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Base_ble_s_ble_s_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Base_ble_s_ble_s_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Base\\ble_s\\ble_s.cmd");
        }
    }
}
