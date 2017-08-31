using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_leaves_nonlocalexitfromnestedcatch_ro_nonlocalexitfromnestedcatch_ro_
    {
        [OuterLoop]
        [Fact]
        public void _eh_leaves_nonlocalexitfromnestedcatch_ro_nonlocalexitfromnestedcatch_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\leaves\\nonlocalexitfromnestedcatch_ro\\nonlocalexitfromnestedcatch_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
