using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ble_u4_ble_u4_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ble_u4_ble_u4_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ble_u4\\ble_u4.cmd");
        }
    }
}
