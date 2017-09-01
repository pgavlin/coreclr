using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _casts_coverage__dbgisinst_ldarg__dbgisinst_ldarg_
    {
        [OuterLoop]
        [Fact]
        public void _casts_coverage__dbgisinst_ldarg__dbgisinst_ldarg_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\coverage\\_dbgisinst_ldarg\\_dbgisinst_ldarg.cmd");
        }
    }
}
