using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _casts_coverage__relisinst_newobj__relisinst_newobj_
    {
        [OuterLoop]
        [Fact]
        public void _casts_coverage__relisinst_newobj__relisinst_newobj_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\coverage\\_relisinst_newobj\\_relisinst_newobj.cmd");
        }
    }
}
