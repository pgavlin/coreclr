using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_eventattributes_EventAttributesNone_EventAttributesNone_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_eventattributes_EventAttributesNone_EventAttributesNone_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\eventattributes\\EventAttributesNone\\EventAttributesNone.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
