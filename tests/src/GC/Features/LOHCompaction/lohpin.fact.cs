using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    class _LOHCompaction_lohpin_lohpin_
    {
        [Fact]
        public void _LOHCompaction_lohpin_lohpin_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Features\\LOHCompaction\\lohpin\\lohpin.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
