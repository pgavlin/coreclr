using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _mutex_abandonedmutex_am01waitallneg_am01waitallneg_
    {
        [OuterLoop]
        [Fact]
        public void _mutex_abandonedmutex_am01waitallneg_am01waitallneg_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\mutex\\abandonedmutex\\am01waitallneg\\am01waitallneg.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
