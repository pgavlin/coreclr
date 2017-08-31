using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_coverage__relcastclass_newobj__relcastclass_newobj_
    {
        [Fact]
        public void _casts_coverage__relcastclass_newobj__relcastclass_newobj_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\coverage\\_relcastclass_newobj\\_relcastclass_newobj.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
