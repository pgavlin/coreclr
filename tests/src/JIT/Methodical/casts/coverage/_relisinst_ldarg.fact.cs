using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _casts_coverage__relisinst_ldarg__relisinst_ldarg_
    {
        [OuterLoop]
        [Fact]
        public void _casts_coverage__relisinst_ldarg__relisinst_ldarg_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\coverage\\_relisinst_ldarg\\_relisinst_ldarg.cmd");
        }
    }
}
