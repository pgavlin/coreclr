using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _regressions_139056_Foo_Foo_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_139056_Foo_Foo_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\139056\\Foo\\Foo.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
