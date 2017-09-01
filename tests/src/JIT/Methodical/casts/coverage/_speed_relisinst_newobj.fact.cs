using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _casts_coverage__speed_relisinst_newobj__speed_relisinst_newobj_
    {
        [OuterLoop]
        [Fact]
        public void _casts_coverage__speed_relisinst_newobj__speed_relisinst_newobj_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\coverage\\_speed_relisinst_newobj\\_speed_relisinst_newobj.cmd");
        }
    }
}
