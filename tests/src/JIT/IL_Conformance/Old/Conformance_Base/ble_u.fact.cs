using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_Conformance_Base_ble_u_ble_u_
    {
        [OuterLoop]
        [Fact]
        public void _Old_Conformance_Base_ble_u_ble_u_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\Conformance_Base\\ble_u\\ble_u.cmd");
        }
    }
}
