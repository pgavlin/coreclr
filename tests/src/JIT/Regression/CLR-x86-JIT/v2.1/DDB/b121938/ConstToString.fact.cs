using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_v2_1_DDB_b121938_ConstToString_ConstToString_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_v2_1_DDB_b121938_ConstToString_ConstToString_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\v2.1\\DDB\\b121938\\ConstToString\\ConstToString.cmd");
        }
    }
}
