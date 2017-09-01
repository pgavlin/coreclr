using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _casts_coverage__speed_dbgisinst_ldarg__speed_dbgisinst_ldarg_
    {
        [OuterLoop]
        [Fact]
        public void _casts_coverage__speed_dbgisinst_ldarg__speed_dbgisinst_ldarg_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\coverage\\_speed_dbgisinst_ldarg\\_speed_dbgisinst_ldarg.cmd");
        }
    }
}
