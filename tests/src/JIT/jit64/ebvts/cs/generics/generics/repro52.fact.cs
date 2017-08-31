using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    class _ebvts_cs_generics_generics_repro52_repro52_
    {
        [OuterLoop]
        [Fact]
        public void _ebvts_cs_generics_generics_repro52_repro52_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\jit64\\ebvts\\cs\\generics\\generics\\repro52\\repro52.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
