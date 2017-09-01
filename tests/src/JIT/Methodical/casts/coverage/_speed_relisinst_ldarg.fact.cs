using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _casts_coverage__speed_relisinst_ldarg__speed_relisinst_ldarg_
    {
        [OuterLoop]
        [Fact]
        public void _casts_coverage__speed_relisinst_ldarg__speed_relisinst_ldarg_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\coverage\\_speed_relisinst_ldarg\\_speed_relisinst_ldarg.cmd");
        }
    }
}
