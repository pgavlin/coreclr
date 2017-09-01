using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ble_r4_ble_r4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ble_r4_ble_r4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ble_r4\\ble_r4.cmd");
        }
    }
}
