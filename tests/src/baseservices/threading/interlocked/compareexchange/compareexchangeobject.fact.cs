using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _interlocked_compareexchange_compareexchangeobject_compareexchangeobject_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_compareexchange_compareexchangeobject_compareexchangeobject_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\compareexchange\\compareexchangeobject\\compareexchangeobject.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
