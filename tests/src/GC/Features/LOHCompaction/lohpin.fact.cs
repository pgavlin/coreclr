using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    public class _LOHCompaction_lohpin_lohpin_
    {
        [Fact]
        public void _LOHCompaction_lohpin_lohpin_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Features\\LOHCompaction\\lohpin\\lohpin.cmd");
        }
    }
}
