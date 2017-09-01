using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    public class _regressions_139056_Foo_Foo_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_139056_Foo_Foo_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\139056\\Foo\\Foo.cmd");
        }
    }
}
