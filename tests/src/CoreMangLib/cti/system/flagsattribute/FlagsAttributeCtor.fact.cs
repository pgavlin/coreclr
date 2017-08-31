using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_flagsattribute_FlagsAttributeCtor_FlagsAttributeCtor_
    {
        [OuterLoop]
        [Fact]
        public void _system_flagsattribute_FlagsAttributeCtor_FlagsAttributeCtor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\flagsattribute\\FlagsAttributeCtor\\FlagsAttributeCtor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
