using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _casts_coverage__il_relisinst_ldarg__il_relisinst_ldarg_
    {
        [OuterLoop]
        [Fact]
        public void _casts_coverage__il_relisinst_ldarg__il_relisinst_ldarg_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\coverage\\_il_relisinst_ldarg\\_il_relisinst_ldarg.cmd");
        }
    }
}
