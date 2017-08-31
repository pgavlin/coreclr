using CoreclrTestLib;
using Xunit;

namespace baseservices_exceptions
{
    class _generics_TypeParameter006_TypeParameter006_
    {
        [OuterLoop]
        [Fact]
        public void _generics_TypeParameter006_TypeParameter006_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\exceptions\\generics\\TypeParameter006\\TypeParameter006.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
