using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_parameterattributes_ParameterAttributesIn_ParameterAttributesIn_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_parameterattributes_ParameterAttributesIn_ParameterAttributesIn_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\parameterattributes\\ParameterAttributesIn\\ParameterAttributesIn.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
